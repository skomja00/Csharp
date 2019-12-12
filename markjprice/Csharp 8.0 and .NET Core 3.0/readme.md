<b><ins>Chapter 01 Hello, C#! Welcome, .NET!</ins></b>
<b><ins>Notes:</b></ins>
  
**Q1.** Why can a programmer use different languages, for example, C# and F#, to write applications that run on .NET Core?  
**A1.** The compiler used by the _dotnet_ CLI tool converts you source code into **Intermediate Language (IL)** code and stores the IL in an assembly (a DLL or EXE file). IL code statements are like assembly language instructions, which are executed by .NET Core's virtrual machine, known as CoreCLR **Common Language Runtime (CLR)**.  **<ins>Regardless of source language all .NET applications use IL code for their instructions stored in an assembly.</ins>**  
1. At runtime, the CLR loads the IL, 
2. **just-in-time (JIT)** compiles it into native CPU instructions, 
3. and then they are executed by the CPU on that machine.    
* JIT: The benefit of __just-in-time (JIT)__ is the same code runs everywhere because of the 2nd CLR compile process.  
* AoT: .NET Native compiles C# code to native CPU instructions __ahead-of-time (AoT)__ rather than using the CLR to compile IL code. This improves execution speed and reduces the memory footprint for applications because the native code is generated at build time and then deployed instead of the IL code. 
  
![IL UML diagram](https://github.com/skomja00/Csharp/blob/master/markjprice/Csharp%208.0%20and%20.NET%20Core%203.0/understanding%20intermediate%20language.png)  

**Q6.** Is .NET Core better the .NET Framework?  
**A6.** Each has strengths and weaknesses because they are all designed for diferent scenarios. As of 2019 .NET is three forked .NET platforms
1. .NET Core: for cross-platform and new apps.
2. .NET Framework: for legacy apps.
3. Xamarin: for mobile apps.

**Q8.** What is the name of the entry point method of a .NET console application and how should it be declared?  
**A8.** The entry point of a C# app must be named Main. Is should be declared as follows: 
```c#
static void Main(string{} args)  
```  


  
<b><ins>Chapter 02 Speaking C#</ins></b>  
<b><ins>Notes:</b></ins> 
  
Steps to create new app.  
1. Create folder  
2. File | Add Folder to Workspace... (i.e. "folder=project")  
3. View | Terminal ( Ctrl + ` )  
4. dotnet new console  
5. View | Command Palette | Omnisharp Select Project  
  
Format strings:
```C#  
{ index [ , alignment ] [ : formatString ] }  
```  
where  
index: number of argument starting at 0  
alignment: +n right align minimum n digits, -n left align min. n digits  
formatString: C currency format, N0 number with 1000s separators no decimal places, etc...  
  
```C#  
// examples 
WriteLine($"{"uint", -8}{sizeof(uint), -2:D}{uint.MinValue, 33:D}{uint.MaxValue, 31:D}");
WriteLine($"{"long", -8}{sizeof(long), -2:D}{long.MinValue, 30}{long.MaxValue, 30}");
WriteLine($"{"ulong", -8}{sizeof(ulong), -2:D}{ulong.MinValue, 33:F0}{ulong.MaxValue, 31:F0}");
WriteLine($"{"float", -8}{sizeof(float), -2:D}{float.MinValue, 33:E7}{float.MaxValue, 31:E7}");
```  
  
  
Namespace:  
Namespace.Type.Method  (i.e. System.Console.Writeln)  
  
  
<table>
<tr>
  <td colspan="3">Working with variables</td>
</tr>
<tr>
    <td colspan="3">text</td>
</tr>
<tr>
    <td>&nbsp;</td>
    <td>char</td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td>string</td>
    <td></td>
</tr>
<tr>
    <td colspan="3">numbers</td>
</tr>
<tr>
    <td></td>
    <td>whole</td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>int</td>
<tr>
    <td></td>
    <td></td>
    <td>long</td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>short</td>
</tr>
</tr>
<tr>
    <td></td>
    <td>real</td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>decimal (comparable)</td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>float</td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>double</td>
</tr>
<tr>
    <td>boolean</td>
    <td></td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td>true | false</td>
    <td></td>
</tr>
<tr>
    <td>generics</td>
    <td></td>
    <td></td>
<tr>
    <td>object type deprecated</td>
    <td></td>
    <td></td>
<tr>
    <td>dynamic type deprecated</td>
    <td></td>
    <td></td>
</tr>
</table> 

