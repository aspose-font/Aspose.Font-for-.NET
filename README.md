# Font Manipulation via .NET API

[Aspose.Font for .NET](https://products.aspose.com/font/net) is a .NET font loading and drawing library. It supports multiple front formats such as TrueType (with TrueType collectons), CFF, OpenType, and Type1. The API provides rich functionality to load/save font and provide information about its data structures along with any glyph that is supported by all the font types. It also provides encoding information for all the font types which represents a mapping between character codes and glyph identifiers. Its rendering subsystem helps end-users to render any desired glyph or text. Special glyphs can be rendered by implementing interface using simple graphics functionality (move point, draw line, curve).

<p align="center">

  <a title="Download complete Aspose.Font for .NET source code" href="https://github.com/aspose-Font/Aspose.Font-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

This repository contain [Examples](Examples) projects for [Aspose.Font for .NET](https://products.aspose.com/Font/net) to help you learn and write your own applications.

Directory | Description
--------- | -----------
[Examples](Examples)  | A collection of .NET examples that help you learn the product features

## Font Processing Features

- Load font files from disc as well as stream.
- Read font information and save updated font files to disc.
- Read Glyphs and Metrics information from Font files.
- Detect Latin Symbols in Fonts.
- Extract embedded licensing information from font files.
- Render text using font glyphs.
- Render text using custom interfaces.

## Read & Write Font Formats

TTF

## Read Font Formats

TTC, OpenType, CFF, Type1

## Platform Independence

Aspose.Font for .NET can be integrated with any kind of ASP.NET Web Application or a Windows Application.

## Getting Started with Aspose.Font for .NET

Are you ready to give Aspose.Font for .NET a try? Simply execute `Install-Package Aspose.Font` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.Font for .NET and want to upgrade the version, please execute `Update-Package Aspose.Font` to get the latest version.

## Check Latin Symbols Support in the Font using C# Code

```csharp
// For complete examples and data files, please go to https://github.com/aspose-font/Aspose.Font-for-.NET
string fileName = dataDir + "Montserrat-Regular.ttf"; //Font file name with full path

FontDefinition fd = new FontDefinition(FontType.TTF, new FontFileDefinition("ttf", new FileSystemStreamSource(fileName)));
TtfFont ttfFont = Aspose.Font.Font.Open(fd) as TtfFont;

bool latinText = true;


for (uint code = 65; code < 123; code++){
    GlyphId gid = ttfFont.Encoding.DecodeToGid(code);
    if (gid == null || gid == GlyphUInt32Id.NotDefId){
        latinText = false;
    }
}

if (latinText){
    Console.WriteLine(string.Format("Font {0} supports latin symbols.", ttfFont.FontName));
}
else{
    Console.WriteLine(string.Format("Latin symbols are not supported by font {0}.", ttfFont.FontName));
}
```

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/font/net) | [Docs](https://docs.aspose.com/font/net/) | [API Reference](https://apireference.aspose.com/font/net) | [Examples](https://github.com/aspose-font/Aspose.Font-for-.NET/tree/master/Examples) | [Blog](https://blog.aspose.com/category/font/) | [Free Support](https://forum.aspose.com/c/font) | [Temporary License](https://purchase.aspose.com/temporary-license)
