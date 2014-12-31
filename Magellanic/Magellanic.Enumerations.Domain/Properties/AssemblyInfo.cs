﻿// ***********************************************************************
// Assembly         : Magellanic.Enumerations.Domain
// Author           : Jeremy Lindsay
// Created          : 21-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 28-Dec-2014
// ***********************************************************************
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Magellanic.Enumerations.Domain")]
[assembly: AssemblyDescription("A collection of enumerations for common domain objects.")]

#if DEBUG
#if NET_45_OR_GREATER
        [assembly: AssemblyConfiguration("Debug, .net 4.5")]
#elif NET_4
        [assembly: AssemblyConfiguration("Debug, .net 4")]
#endif
#else
#if NET_45_OR_GREATER
        [assembly: AssemblyConfiguration("Release, .net 4.5")]
#elif NET_4
        [assembly: AssemblyConfiguration("Release, .net 4")]
#endif
#endif


[assembly: AssemblyCompany("Jeremy Lindsay, 2014")]
[assembly: AssemblyProduct("Magellanic.Enumerations.Domain")]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("be9bc767-1544-4c3a-8fd2-a1949ebb8d1b")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("0.1.*")]
