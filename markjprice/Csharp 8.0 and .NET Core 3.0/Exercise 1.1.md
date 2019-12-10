1. Why can a programmer use different languages, for example, C# and F#, to write applications that run on .NET Core?  

  * Page 14. All source code language is converted to a common assembler type code, **Intermediate Language (IL) **, in a DLL or EXE file. The .NET Core virtual machine, known as CoreCLR (Common Language Runtime), shares the same assembler code.  



```mermaid
graph LR
C(C# source)
F(F# source)
V(Visual Basic)
    C --> I(Intermediate Language)
    F --> I(Intermediate Language)
    V --> I(Intermediate Language)
        I --> AoTL(AoT compile Linux)
        I --> AoTM(AoT compile macOS)
        I --> AoTW(AoT compile Win)
        I --> J(JIT compile)
            J --> JITW(Linux)
            J --> JITL(macOS)
            J --> JITM(Win)
            
```

```markdown

```
