**Q1.** Why can a programmer use different languages, for example, C# and F#, to write applications that run on .NET Core?  

**A1.** Page 14. Source code is converted to a common assembler type code, **Intermediate Language (IL)**, in a DLL or EXE file. The .NET Core virtual machine, CoreCLR (Common Language Runtime), shares the same assembler code.  
  
![IL UML diagram](https://bramp.github.io/js-sequence-diagrams/images/sample.svg)
