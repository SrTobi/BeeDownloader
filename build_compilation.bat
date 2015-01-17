@echo off

setlocal
set PATH=%PATH%;C:\Program Files\WinRar\
set comp=compilation
set file=BeeDownloader.zip
set target=Debug

echo Build compilation...
echo Target=%target%

mkdir %comp%
winrar a -afzip -ep %comp%\%file% ^
						README.md ^
						license.md ^
						BeeDownloader\bin\%target%\mb_BeeDownloader.dll^
						BeeDownloader\bin\%target%\Newtonsoft.Json.dll^
						BeeDownloader\bin\%target%\policy.2.0.taglib-sharp.dll^
						BeeDownloader\bin\%target%\taglib-sharp.dll^
						BeeDownloader\bin\%target%\YoutubeExtractor.dll

