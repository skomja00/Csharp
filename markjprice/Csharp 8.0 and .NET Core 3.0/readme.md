<h2>Chapter 01 Hello, C#! Welcome, .NET!</h2>
<ul>
	<li>A programmer can use different languages, for example, C# and F#, to write applications that run on .NET Core. <br>Regardless of source language all .NET applications use IL code for their instructions stored in an assembly. <br> The compiler used by the _dotnet_ CLI tool converts your source code into <b>Intermediate Language (IL)</b> code and stores the IL in an assembly (a DLL or EXE file). IL code statements are like assembly language instructions, which are executed by .NET Core's virtrual machine, known as CoreCLR <b>Common Language Runtime (CLR)</b>.
	</li>
		<ol>
			<li>At runtime, the CLR loads the IL, </li>
			<li><b>just-in-time (JIT)</b> compiles it into native CPU instructions, </li>
			<li>and then they are executed by the CPU on that machine.</li>
		</ol>
		<ul>
			<li>
				<b>JIT:</b> The benefit of <b>just-in-time (JIT)</b> is the same code runs everywhere because of the 2nd CLR compile process.
			</li>
			<li>
				<b>AoT:</b> .NET Native compiles C# code to native CPU instructions <b>ahead-of-time (AoT)</b> rather than using the CLR to compile IL code at runtime. This improves execution speed and reduces the memory footprint for applications because the native code is generated at build time and then deployed instead of the IL code.
			</li>
		</ul>
		![Homemade IL UML diagram](https://github.com/skomja00/Csharp/blob/master/markjprice/Csharp%208.0%20and%20.NET%20Core%203.0/understanding%20intermediate%20language.png)
	</li>
	<li>Both the .NET Core and the .NET Framework have strengths and weaknesses because they are all designed for diferent scenarios. As of 2019 .NET branched into three .NET platforms. 
		<ol>
			<li>
				.NET Core: for cross-platform and new apps.
			</li>
			<li>
				.NET Framework: for legacy apps.
			</li>
			<li>
				Xamarin: for mobile apps.
			</li>
		</ol>
	</li>
</ul>
<h2>Chapter 02 Speaking C#</h2>
<ul>
	<li>Steps to create new app.
		<ol>
			<li>
				Create folder
			</li>
			<li>
				File | Add Folder to Workspace... (i.e. "folder=project")
			</li>
			<li>
				View | Terminal ( Ctrl + ` )
			</li>
			<li>
				dotnet new console
			</li>
			<li>
				View | Command Palette | Omnisharp Select Project
			</li>
		</ol>
	</li>
	<li>
		Formatting using numbered positional arguments:<br>
		<code>{ index [ , alignment ] [ : formatString ] }</code><br>
		where<br>
		index: number of argument starting at 0<br>
		alignment: +n right align minimum n digits, -n left align min. n digits<br>
		Formatting using interpolated strings:
			<code><br>// examples  </code><br>
			<code>WriteLine($"{"long", -8}{sizeof(long), -2:D}{long.MinValue, 30}{long.MaxValue, 30}"); </code><br> 
			<code>WriteLine($"{"float", -8}{sizeof(float), -2:D}{float.MinValue, 30:E7}{float.MaxValue, 30:E7}");  </code><br>
			<code>// output  </code><br>
			<code>long    8           -9223372036854775808           9223372036854775807  </code><br>
			<code>float   4                -3.4028235E+038                3.4028235E+038  </code><br>
	</li>
	<li>
		Two ways to use formatted strings<br>
			<code>int a=1,b=2,n=999;</code><br>
			<code>// formatting using numbered positional arguments  </code><br>
			<code>WriteLine(  </code><br>
			<code>&nbsp;&nbsp;&nbsp;&nbsp;format: "a={0}, b={1} ... n={2}", // NO $ prefix on the format string!</code><br>  
			<code>&nbsp;&nbsp;&nbsp;&nbsp;arg0: a,  </code><br>
			<code>&nbsp;&nbsp;&nbsp;&nbsp;arg1: b,  </code><br>
			<code>&nbsp;&nbsp;&nbsp;&nbsp;// ...  </code><br>
			<code>&nbsp;&nbsp;&nbsp;&nbsp;argn: n  </code><br>
			<code>);  </code><br>
			<code>// formatting using interpolated strings  </code><br>
			<code>WriteLine(  </code><br>
			<code>&nbsp;&nbsp;&nbsp;&nbsp;$"a={a}, b={b} ... n={n}" // $ prefix BUT NO positional args  </code><br>
			<code>);  </code><br>
			<code>// output  </code><br>
			<code>//  a=1, b=2 ... n=999  </code><br>
			<code>//  a=1, b=2 ... n=999  </code><br>
		</code>
	</li>
	<li>
		Working with variables.
		<table>
		<tr>
		  <td colspan="3" align="center">Working with variables</td>
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
		</tr>
		<tr>
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
	</li>
</ul>
<h2>Chapter 03 Controlling Flow and Converting Types</h2>
<ul>
	<li>
		Jump Statements<br>
		<code>
			break // break statement terminates the closest enclosing loop or switch<br>
			continue // statements between continue and end of the code block body are skipped<br>
			return // terminates execution of the method in which it appears and returns control to the calling method.
		</code>
	</li>
	<li>
		<code>
			TryParse
		</code>
		Attempt to convert the input string and return true if it can convert it and false if it cannot. The `out` keyword is required to all the `TryParse` method to set a variable when the conversion works.
	</li>
	<li>
		<code>
			foreach
		</code> Technically, the foreach statement will work on any type that follows these rules:<br>
		<ol>
			<li>
				The type must have a method named GetEnumerator() that returns an object
			</li>
			<li>
				The returned object must have a read-only property named Current
			</li>
			<li>
				The MoveNext() method must return true if more items or false otherwise
			</li>
		</ol>
	</li>
</ul>
<h2>Chapter 04 Writing, Debugging, and Testing Functions</h2>
<ul>
	<li>
		<code>xUnit.net</code> unit testing
	</li>
	<li>
		<code>dotnet new xunit</code> Create and navigate to the new subfolder (hint: name the folder "test subject class name here"UnitTests).
		Add a ProjectReference in the new .csproj.  Hint: Rename UnitTest1.cs created by the template to something more meaningful.<br>
	</li>
		<img src="https://github.com/skomja00/Csharp/blob/master/markjprice/Csharp%208.0%20and%20.NET%20Core%203.0/-test%20subject%20class%20name%20here-UnitTests.csproj.png" alt="..." align="center">	
	<li>
		<code>dotnet build</code> Look for a clean build. This compiles <u>both</u> this new class and also dependency projects listed in the ProjectReference.<br>
	</li> 
	<li>
		<code>dotnet test</code> After writing unit tests, run the unit tests and see the results. A will-written unit test will have three parts.<br>
		<ol>
			<li>
				<b>Arrange:</b> This part will declare and instntiate variable for input and output.
			</li>
			<li>
				<b>Act:</b> This part will execute the unit that you are testing (i.e. calling the method that we want to test).
			</li>
			<li>
				<b>Assert:</b> This part will make one or more assertions about the output. An assertion is a belief that if not true indicates a failed test. For example, when adding 2 and 2 we would expect the result would be 4.
			</li>
		</ol>
	</li>
		<img src="https://github.com/skomja00/Csharp/blob/master/markjprice/Csharp%208.0%20and%20.NET%20Core%203.0/-test%20subject%20class%20name%20here-UnitTests-dotnet-test-results.png" alt="..." align="center">
</ul>
<h2>Chapter 05 Building Your Own Types with OOP</h2>
Class library assemblies group "types" together into easily deployable units (DLL). To write reusable code, you should put it in a class library assembly, just like Microsoft does. Referencing an assembly:
<ol>
    <li>
		Update your new *.csproj with a reference to the class library assembly <code>&lt;ItemGroup&gt;&lt;ProjectReference Include=".../path/file"</code>
	</li>
    <li>
		Import the namespace into your new app to use a type from the class library assembly (i.e. <code>using Packt.Shared;</code>)
	</li>
    <li>
		<code>dotnet build</code> to compile <u>both</u> the new app and its dependency projects.
	</li>
</ol>
<h2>Chapter 06 Implementing Interfaces and Inheriting Classes</h2>
<ul>
	<li>
		Simplifying methods
		<ul>
			<li><b><u>"instance"</u></b> methods are actions that an object does to itself;</li>
			<li><b><u>static</u></b> methods are actions the type does.</li>
		</ul>
	</li>
	<li>
		Raising and handling events are built on delegates.
		<ul>
			<li>
				<b><u>Methods</u></b> are actions that an object can perform, either on itself or to related objects.
			</li>
			<li>
				<b><u>Events</u></b> are actions that happen to an object. Another way of thinking of event is that they provide a way of exchanging messages between two objects.
			</li>
		</ul>
		<table border="1">
			<tr>
			  <td colspan="2" align="center">Raising and handling events</td>
			</tr>
			<tr>
			  <td>in the class.cs</td>
			  <td>in the program.cs</td>
			</tr>
			<tr>
			  <td>public EventHandler DelegateMethod;</td>
			  <td>someobject.DelegateMethod = "Object_Event" (i.e. method name);</u></td>
			</tr>
			<tr>
			  <td>call DelegateMethod(this, EventArgs.Empty);</td>
			  <td>private static void "Object_Event"(Object sender, EventArgs e)</td>
			</tr>
		</table>
	</li>

</body>
</html>
