<style>
.center {
  text-align: center;
  border: 3px solid gray;
}
</style>
<! ––-------------------------------------------------------->
<div class="center">
  <b>Chapter 01 Hello, C#! Welcome, .NET!</b>
</div>
<b>Note:</b><br>
A programmer can use different languages, for example, C# and F#, to write applications that run on .NET Core. <br>Regardless of source language all .NET applications use IL code for their instructions stored in an assembly. <br> The compiler used by the _dotnet_ CLI tool converts your source code into <b>Intermediate Language (IL)</b> code and stores the IL in an assembly (a DLL or EXE file). IL code statements are like assembly language instructions, which are executed by .NET Core's virtrual machine, known as CoreCLR <b>Common Language Runtime (CLR)</b>.
<ol>
	<li>At runtime, the CLR loads the IL, </li>
	<li><b>just-in-time (JIT)</b> compiles it into native CPU instructions, </li>
	<li>and then they are executed by the CPU on that machine.</li>
</ol>
<b>JIT:</b>The benefit of <b>just-in-time (JIT)</b> is the same code runs everywhere because of the 2nd CLR compile process.<br>
<b>AoT:</b>.NET Native compiles C# code to native CPU instructions <b>ahead-of-time (AoT)</b> rather than using the CLR to compile IL code at runtime. This improves execution speed and reduces the memory footprint for applications because the native code is generated at build time and then deployed instead of the IL code. 
<br>
![Homemade IL UML diagram](https://github.com/skomja00/Csharp/blob/master/markjprice/Csharp%208.0%20and%20.NET%20Core%203.0/understanding%20intermediate%20language.png)<br>
<br>
<br><br><b>Note:</b><br>
Both the .NET Core and the .NET Framework have strengths and weaknesses because they are all designed for diferent scenarios. As of 2019 .NET is three forked .NET platforms
<ol>
	<li>.NET Core: for cross-platform and new apps.
	<li>.NET Framework: for legacy apps.
	<li>Xamarin: for mobile apps.
</ol>
<br>
<br>
<br>
<br>
<br>
<! ––-------------------------------------------------------->
<div class="center">
  <b>Chapter 02 Speaking C#</b>
</div>
<b>Note:</b><br>
Steps to create new app.
<ol>
	<li>Create folder<br>
	<li>File | Add Folder to Workspace... (i.e. "folder=project")<br>
	<li>View | Terminal ( Ctrl + ` )<br>
	<li>dotnet new console<br>
	<li>View | Command Palette | Omnisharp Select Project<br>
</ol>
<br>
<br>
<b>Note:</b><br>
Formatting using numbered positional arguments:<br>
<code>
{ index [ , alignment ] [ : formatString ] }<br>
</code>
where<br>
index: number of argument starting at 0<br>
alignment: +n right align minimum n digits, -n left align min. n digits<br>
Formatting using interpolated strings:<br>
<code>
// examples
</code>
<code>
WriteLine($"{"uint", -8}{sizeof(uint), -2:D}{uint.MinValue, 33:D}{uint.MaxValue, 31:D}");
</code>
<code>
WriteLine($"{"long", -8}{sizeof(long), -2:D}{long.MinValue, 30}{long.MaxValue, 30}");
</code>
<code>
WriteLine($"{"ulong", -8}{sizeof(ulong), -2:D}{ulong.MinValue, 33:F0}{ulong.MaxValue, 31:F0}");
</code>
<code>
WriteLine($"{"float", -8}{sizeof(float), -2:D}{float.MinValue, 33:E7}{float.MaxValue, 31:E7}");
</code>
<br>
<br>
<b>Note:</b>Two ways to use formatted strings<br>
<code>
int a=1,b=2,n=999;<br>
// formatting using numbered positional arguments<br>
WriteLine(<br>
&nbsp;&nbsp;&nbsp;&nbsp;format: "a={0}, b={1} ... n={2}", // NO $ prefix on the format string!<br>
&nbsp;&nbsp;&nbsp;&nbsp;a,<br>
&nbsp;&nbsp;&nbsp;&nbsp;b,<br>
&nbsp;&nbsp;&nbsp;&nbsp;// ...<br>
&nbsp;&nbsp;&nbsp;&nbsp;n<br>
);<br>
// formatting using interpolated strings<br>
WriteLine(<br>
&nbsp;&nbsp;&nbsp;&nbsp;$"a={a}, b={b} ... n={n}" // $ prefix BUT NO positional args<br>
);<br>
// output<br>
//  a=1, b=2 ... n=999<br>
//  a=1, b=2 ... n=999
</code>
<br>
<br>
<b>Note:</b>
<table>
<tr>
  <td colspan="3">Working with variables</td>
</tr>
<tr>
    <td colspan="3">text</td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>char</b></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>string</b><br>  </td>
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
    <td><b>int</b></td>
<tr>
    <td></td>
    <td></td>
    <td><b>long</b></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>short</b></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>byte</b> Represents unsigned integers with values from 0 to 255</td>
</tr><tr>
    <td></td>
    <td>real</td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>decimal</b> (comparable)</td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>float</b></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>double</b></td>
</tr>
<tr>
    <td>boolean</td>
    <td></td>
    <td><b>bool</b> Value true or false</td>
</tr>
<tr>
    <td>object</td>
    <td></td>
    <td>C# 1.0 messier code and possible poor performance</td>
</tr>
<tr>
    <td>generics</td>
    <td></td>
    <td>C# 2.0 better alternative to object type</td>
</tr>
<tr>
    <td>dynamic</td>
    <td></td>
    <td>C# 4.0 </td>
</tr>
</table>
<br>
<br>
<br>
<br>
<br>
<! ––-------------------------------------------------------->
<div class="center">
  <b>Chapter 03 Controlling Flow and Converting Types</b>
</div><br>
<b>Note: Jump Statements</b><br>
<code>
break // break statement terminates the closest enclosing loop or switch 
</code><br>
<code>
continue // statements between continue and end of the code block body are skipped
</code><br>
<code>
return // terminates execution of the method in which it appears and returns control to the calling method.
</code>
<br>
<br>
<b>Note: TryParse</b><br>
<code>
TryParse
</code>
Attempt to convert the input string and return true if it can convert it and false if it cannot. The `out` keyword is required to all the `TryParse` method to set a variable when the conversion works.
<br>
<br>
<b>Note:</b>
<code>
foreach
</code> Technically, the foreach statement will work on any type that follows these rules:<br>
<ol>
	<li>The type must have a method named GetEnumerator() that returns an object
	<li>The returned object must have a read-only property named Current
	<li>The MoveNext() method must return true if more items or false otherwise
</ol>
<br>
<br>
<br>
<br>
<! ––-------------------------------------------------------->
<div class="center">
  <b>Chapter 04 Writing, Debugging, and Testing Functions</b>
</div><br>
<b>Note: say wha?</b><br>
<code>dotnet add package Microsoft...</code>
<code>dotnet run --configuration Release | Debug</code>
<code>dotnet new classlib</code>
<code>dotnet new xunit</code>
<code>dotnet new build</code>
<code>dotnet new test</code>
