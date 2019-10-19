19.10.2019: This project is not maintained. I don't use MusicBee anymore and don't even have the developer tools on my computer. Please feel free to fork it. The main reason why it does not work might be the [YoutubeExtractor library](https://github.com/flagbug/YoutubeExtractor), which seems to be abandoned as well. There are however many forks of it, so you might be able to find one that is working.

# BeeDownloader

This plugin adds a downloader to MusicBee, which enables you to download videos from youtube, extract their audio tracks and automatically 
add them to your inbox.

## Install

Clone this repository and compile the project.
Place the mb_BeeDownloader.dll into the plugin folder of MusicBee.
To work properly you also need to place the following dll's into the same folder:

- Newtonsoft.Json.dll
- policy.2.0.taglib-sharp.dll
- taglib-sharp.dll
- YoutubeExtractor.dll


## License

BeeDownloader uses the following external libraries, which all have different licenses.
BeeDownloader itself is licensed under the [MIT License](http://opensource.org/licenses/MIT).


### YoutubeExtractor

YoutubeExtractor is licensed under the [MIT License](http://opensource.org/licenses/MIT) too.
See the [git repository](https://github.com/flagbug/YoutubeExtractor/) for more informations.

### FlvExtract

YoutubeExtractor uses [FlvExtract](http://moitah.net/) for audio extraction, which is licensed under the [GNU General Public License version 2 (GPLv2)](http://opensource.org/licenses/gpl-2.0).

### TagLib-Sharp

[TagLib-Sharp](https://github.com/mono/taglib-sharp/) is used to set the media tags. This library is licensed under the [LGPL](http://opensource.org/licenses/LGPL-2.1).
