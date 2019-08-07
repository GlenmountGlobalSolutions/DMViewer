# DMViewer
PDF File viewer. Commonly used to view drive manuals and automatically search for fault codes in the manual.

## Command Line Syntax
DMViewer.exe *\<PDF File to Open\>* /S=*\<Search Text\>* /P=*\<Start Page\>* /T=*\<Time Delay\>*
- *\<PDF File to Open\>* - The file name of the PDF to be searched
- *\<Search Text\>* - The text to search for
- *\<Start Page\>* - The page to start searching on
- *\<Time Delay\>* - Used to allow more time for the PDF file to load before searching. Increase the time delay if the search and start page functions are not working when DMViewer starts.

## Command Line Example
The following command opens PDF file "S120ListManual.pdf" and searches for text "F06300" starting at page 2391. Setting the start page helps when the search text is referenced earlier in the document in an unrelated section. For instance, if you want to search for drive fault codes, you should set the start page to the first page of the drive fault code chapter or section.

```DMViewer.exe S120ListManual.pdf /S=F06300 /P=2391```

## Executable Files
The latest executable files can be found under releases.
https://github.com/GlenmountGlobalSolutions/DMViewer/releases

