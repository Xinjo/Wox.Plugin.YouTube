# Wox.Plugin.YouTube
Search YouTube videos in Wox (http://www.getwox.com)

# Installing the plugin  

1. Compile the project using Visual Studio 2012/2013/2015
2. Zip the DLL with a `plugin.json` file, create a new text file and rename it
```
{
  "ID":"D2D2C23B084D411DB66FE0C79D6C2A6H",                    //Plugin ID，32 bit UUID
  "ActionKeyword":"yt",                                       //Plugin default action keyword
  "Name":"YouTube",                                           //Plugin name
  "Description":"YouTube search plugin for Wox",              //Plugin description
  "Author":"Xinjo",                                           //Plugin Author
  "Version":"1.0.0",                                          //Plugin version，must be x.x.x format
  "Language":"csharp",                                        //Plugin language，we support csharp,python and executable now
  "Website":"https://github.com/Xinjo/Wox.Plugin.YouTube/",   //Plugin website or author website
  "IcoPath": "Images\\pic.png",                               //Plugin icon, relative path to the pluign folder
  "ExecuteFileName":"Wox.Plugin.YouTube.dll"                  //Execution entry. Dll name for c# plugin, and python file for python plugin
}
```
3. TODO
4. TODO
5. TODO
