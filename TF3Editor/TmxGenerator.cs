using PluginVideoSega;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TMX
{
    public class TmxGenerator
    {
        private XDocument tmx = null;

        public delegate int FuncXYtoTileIndex(ushort width, ushort x, ushort y);

        public delegate Tuple<ushort, ushort> FuncTileIndexToXY(ushort width, int tileIndex);

        public TmxGenerator()
        {
            tmx = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"));
        }

        public TmxGenerator(string fileName)
        {
            tmx = XDocument.Load(fileName);
        }

        public static TmxGenerator FromFile(string fileName)
        {
            if (!File.Exists(fileName)) return null;

            return new TmxGenerator(fileName);
        }

        public void Save(string path)
        {
            if (tmx == null) return;

            tmx.Save(path);
        }

        public void WriteMap(ushort width, ushort height)
        {
            if (tmx == null) return;

            tmx.Add(
                new XElement("map",
                    new XAttribute("version", "1.0"),
                    new XAttribute("orientation", "orthogonal"),
                    new XAttribute("renderorder", "right-down"),
                    new XAttribute("width", width.ToString()),
                    new XAttribute("height", height.ToString()),
                    new XAttribute("tilewidth", 8.ToString()),
                    new XAttribute("tileheight", 8.ToString()),
                    new XAttribute("nextobjectid", "1")
                    )
                    );
        }

        public void WriteIntProperty(string name, int value)
        {
            XElement map = tmx.Element("map");
            if (map == null) return;

            XElement properties = new XElement("properties");
            properties.Add(
                new XElement("property",
                    new XAttribute("name", name),
                    new XAttribute("type", "int"),
                    new XAttribute("value", value.ToString())
                )
                );

            map.Add(properties);
        }

        public void ReadIntProperty(string name, out int value)
        {
            value = 0;

            XElement map = tmx.Element("map");
            if (map == null) return;

            XElement properties = map.Element("properties");
            if (properties == null) return;

            XElement property = properties.Descendants("property").FirstOrDefault(l => (l.Attribute("name").Value == name && l.Attribute("type").Value == "int"));
            value = int.Parse(property.Attribute("value").Value);
        }

        public void WriteTileset(string name, string image, Color transColor, int firstGid, ushort startTileIndex)
        {
            if (tmx == null) return;

            XElement map = tmx.Element("map");
            if (map == null) return;

            map.Add(
                new XElement("tileset",
                    new XAttribute("firstgid", (startTileIndex + firstGid).ToString()),
                    new XAttribute("name", name),
                    new XAttribute("tilewidth", 8.ToString()),
                    new XAttribute("tileheight", 8.ToString()),

                    new XElement("image",
                        new XAttribute("source", image),
                        new XAttribute("trans", string.Format("{0:x2}{1:x2}{2:x2}", transColor.R, transColor.G, transColor.B))
                        )
                    )
                );
        }

        public void ReadTileset(string name, out string imagePath, out Color transColor, out int firstGid)
        {
            imagePath = string.Empty;
            firstGid = 0;
            transColor = Color.Black;

            if (tmx == null) return;

            XElement map = tmx.Element("map");
            if (map == null) return;

            XElement tileset = map.Descendants("tileset").FirstOrDefault(l => l.Attribute("name").Value == name);
            firstGid = int.Parse(tileset.Attribute("firstgid").Value);

            XElement image = tileset.Element("image");
            imagePath = image.Attribute("source").Value;
            transColor = ColorTranslator.FromHtml(string.Format("#{0}", image.Attribute("trans").Value));
        }

        public void LayerFromMapping(string name, ushort[] mapping, int firstGid, ushort layerWidth, ushort layerHeight, FuncXYtoTileIndex funcXYtoTileIndex)
        {
            if (tmx == null) return;

            XElement map = tmx.Element("map");
            if (map == null) return;

            map.Add(
                new XElement("layer",
                    new XAttribute("name", name),
                    new XAttribute("width", layerWidth.ToString()),
                    new XAttribute("height", layerHeight.ToString())
                    )
                );

            XElement layer = map.Descendants("layer").FirstOrDefault(l => l.Attribute("name").Value == name);
            XElement data = new XElement("data");

            for (ushort y = 0; y < layerHeight; ++y)
                for (ushort x = 0; x < layerWidth; ++x)
                {
                    int idx = funcXYtoTileIndex(layerWidth, x, y);
                    ushort word = mapping[idx];

                    uint gid = Mapper.TileIdx(word);
                    if (Mapper.HF(word))
                        gid |= 0x80000000;
                    if (Mapper.VF(word))
                        gid |= 0x40000000;

                    data.Add(
                        new XElement("tile",
                            new XAttribute("gid",
                                (gid + firstGid).ToString())
                            )
                        );
                }

            layer.Add(data);
        }

        public void LayerToMapping(string name, out ushort[] mapping, int firstGid, ushort startTileIndex, byte palIndex, out ushort layerWidth, out ushort layerHeight, FuncXYtoTileIndex funcXYtoTileIndex)
        {
            layerWidth = layerHeight = 0;
            mapping = null;

            if (tmx == null) return;

            XElement map = tmx.Element("map");
            if (map == null) return;

            XElement layer = map.Descendants("layer").FirstOrDefault(l => l.Attribute("name").Value == name);

            layerWidth = ushort.Parse(layer.Attribute("width").Value);
            layerHeight = ushort.Parse(layer.Attribute("height").Value);

            XElement data = layer.Element("data");
            if (data == null) return;

            mapping = new ushort[data.Elements().Count()];

            int tileIndex = 0;
            for (ushort y = 0; y < layerHeight; ++y)
                for (ushort x = 0; x < layerWidth; ++x)
                {
                    XElement tile = data.Elements().ElementAt(tileIndex++);

                    uint gid = (uint)(startTileIndex + uint.Parse(tile.Attribute("gid").Value) - firstGid);
                    bool HF = (gid & 0x80000000) != 0;
                    bool VF = (gid & 0x40000000) != 0;

                    if (HF) gid -= 0x80000000;
                    if (VF) gid -= 0x40000000;

                    int idx = funcXYtoTileIndex(layerWidth, x, y);
                    mapping[idx] = Mapper.EncodeTileInfo((ushort)gid, HF, VF, palIndex, false);
                }
        }

        public static int TilesetExport(string path, byte[] tiles, Color[] palette)
        {
            int tilesCount;
            Bitmap map = VideoSega.TilesetFromData(tiles, palette, out tilesCount);
            if (map != null) map.Save(path);

            return tilesCount;
        }

        public static void TilesetImport(string path, out byte[] tiles, out Color[] palette)
        {
            Bitmap image = (Image.FromFile(path) as Bitmap);

            ushort[] mapping;
            ushort width, height;

            VideoSega.ImageToData(image, null, out tiles, out mapping, out palette, out width, out height);
        }

        public static int ConvertXYtoTileIndexDef(ushort width, ushort x, ushort y)
        {
            return (y * width + x);
        }
    }
}