__Chapter 01 Hello, C#! Welcome, .NET!__  
  
Exercise:  
**Q1.** Why can a programmer use different languages, for example, C# and F#, to write applications that run on .NET Core?  
**A1.** Page 14. Source code is converted to a common assembler type code, **Intermediate Language (IL)**, in a DLL or EXE file. The .NET Core virtual machine, CoreCLR (Common Language Runtime), shares the same assembler code. 
* JIT: The benefit of __just-in-time (JIT)__ is the same code runs everywhere because of the CLR compile process.  
* AoT: .NET Native compiles C# code to native CPU instructions __ahead-of-time (AoT)__ rather than using the CLR to compile IL code. This improves execution speed and reduces the memory footprint for applications because the native code is generated at build time and then deployed instead of the IL code. 
  
![IL UML diagram](https://github.com/skomja00/Csharp/blob/master/markjprice/Csharp%208.0%20and%20.NET%20Core%203.0/understanding%20intermediate%20language.png)  
    
**Q2.** What do you type at the prompt to create a console app?  
**A2.** `dotnet new console`  

**Q3.** What do you type at the prompt to build and execute C# source code?  
**A3.** `dotnet run`

**Q4.** What is the Visual Studio Code keyboard shortcut to view Terminal?  
**A4.** Windows Ctrl + (single-quote)

**Q5.** Is Visual Studio 2019 better than Visual Studio Code?  
**A5.**  
* VSCode is the most modern and lightwight code editor to choose, and the only one from Microsoft that is cross-platform. Cannot build Windows and mobile apps.  
* VS only runs on Windows. The only MS developer tool that can create Windoes Desktop and mobile apps.   

**Q6.** Is .NET Core better the .NET Framework?  
**A6.** Each has strengths and weaknesses because they are all designed for diferent scenarios. As of 2019 .NET is three forked .NET platforms
1. .NET Core: for cross-platform and new apps.
2. .NET Framework: for legacy apps.
3. Xamarin: for mobile apps.

**Q7.** What is .NET Standard and why is it important?  
**A7.** 
* .NET Standard is just a standard. You cannot install it. To use it you must install a .NET platform that implements the minimum specification for a set of APIs that all .NET plaforms can implement. Basic support is indicated by a platform being compliant with .NET Standard 1.4.

**Q8.** What is the name of the entry point method of a .NET console application and how should it be declared?  
**A8.** The entry point of a C# app must be named Main. Is should be declared as follows: 
```c#
static void Main(string{} args)  
```  

**Q9.** Where would you look for help about a C# keyword?  
**A9.** The most useful keyboard shortcut in VSCode is _F12_ to __Go To Definition__. This will show what the public definition of the type or member looks like by reading the metadata in the compiled assembly. ILSpy .NET Decompiler will even reverse-engineer from the metadata and IL code back into C# for you. 

**Q10.** Where would you look for solutions to common programming problems?  
**A10.** __Stack Overflow__ is the most popular third-party website for getting answers to difficult programming questions. It's so popular that search engines such as __DuckDuckGo__ have a special way to write a query to search the site. 
```DuckDuckGo
!so securestring
```

__Chapter 0Speaking C#__  
