﻿namespace System
open System.Reflection
open System.Runtime.CompilerServices

[<assembly: AssemblyTitleAttribute("FSharpx.Collections.Experimental")>]
[<assembly: AssemblyProductAttribute("FSharpx.Collections")>]
[<assembly: AssemblyDescriptionAttribute("FSharpx.Collections is a collection of datastructures for use with F# and C#.")>]
[<assembly: InternalsVisibleToAttribute("FSharpx.Collections.Tests")>]
[<assembly: InternalsVisibleToAttribute("FSharpx.Collections.Experimental.Tests")>]
[<assembly: AssemblyVersionAttribute("1.14.0")>]
[<assembly: AssemblyFileVersionAttribute("1.14.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.14.0"
