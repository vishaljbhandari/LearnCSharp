using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Basic
{
    class Enviornment
    {

        public void Framework()
        {
            /*
                The .Net framework is a revolutionary platform that helps you to write the following types of applications −
                    Windows applications
                    Web applications
                    Web services

                The .Net framework applications are multi-platform applications. The framework has been designed in such a way that it can be used from any of the following languages: C#, C++, Visual Basic, Jscript, COBOL, etc. All these languages can access the framework as well as communicate with each other.

                The .Net framework consists of an enormous library of codes used by the client languages such as C#. Following are some of the components of the .Net framework −

                Common Language Runtime (CLR)
                The .Net Framework Class Library
                Common Language Specification
                Common Type System
                Metadata and Assemblies
                Windows Forms
                ASP.Net and ASP.Net AJAX
                ADO.Net
                Windows Workflow Foundation (WF)
                Windows Presentation Foundation
                Windows Communication Foundation (WCF)
                LINQ
            */
        }

        public void IDE()
        {
            /*
                Integrated Development Environment (IDE) for C#
                Microsoft provides the following development tools for C# programming −

                Visual Studio 2010 (VS)
                Visual C# 2010 Express (VCE)
                Visual Web Developer
                The last two are freely available from Microsoft official website. Using these tools, you can write all kinds of C# programs from simple command-line applications to more complex applications. You can also write C# source code files using a basic text editor, like Notepad, and compile the code into assemblies using the command-line compiler, which is again a part of the .NET Framework.

                Visual C# Express and Visual Web Developer Express edition are trimmed down versions of Visual Studio and has the same appearance. They retain most features of Visual Studio. In this tutorial, we have used Visual C# 2010 Express.

                You can download it from Microsoft Visual Studio. It gets installed automatically on your machine.

                Note: You need an active internet connection for installing the express edition.
             */
        }

        public void NonWindows()
        {
            /*
                Writing C# Programs on Linux or Mac OS
                Although the.NET Framework runs on the Windows operating system, there are some alternative versions that work on other operating systems. Mono is an open-source version of the .NET Framework which includes a C# compiler and runs on several operating systems, including various flavors of Linux and Mac OS. Kindly check Go Mono.

                The stated purpose of Mono is not only to be able to run Microsoft .NET applications cross-platform, but also to bring better development tools for Linux developers. Mono can be run on many operating systems including Android, BSD, iOS, Linux, OS X, Windows, Solaris, and UNIX.
             */
        }

        public void EnvironmentSetup()
        {
            /*
                Steps for C# Environment Setup
                Here are the essential steps to set up the C# environment for seamless development:

                Step 1: Installing .NET SDK
                    .NET SDK (Software Development Kit), which includes:
                        C# Compiler (csc.exe)
                        .NET CLI (Command Line Interface)
                        .NET Runtime for running C# applications
                Step 2: Choosing a C# Code Editor
                    Visual Studio	Full-featured C# development
                    Visual Studio Code (VS Code)	Lightweight & cross-platform
                    JetBrains Rider	Advanced C# & Unity development
                    Recommended: Use VS Code or Visual Studio for the best development experience.

                Step 3: Setting Up C# in Visual Studio Code
                    To write and run C# programs in VS Code, you need to install the C# extension.

                    Open VS Code.
                    Go to Extensions (Ctrl+Shift+X).
                    Search for "C#" and install the C# Dev Kit extension.
                Step 4: Writing Your First C# Program
                Step 5: Running Your First C# Program

             */
        }

        public void AdvanceEnvironmentSetup()
        {
            /*
                1. Installing NuGet Packages
                    NuGet is a package manager for .NET that allows you to add libraries and dependencies to your C# projects easily. To install a NuGet package, use the following command:
                        dotnet add package Newtonsoft.Json
                    This will add the Newtonsoft.Json package, which is commonly used for JSON serialization and deserialization.

                2. Debugging C# Code
                    Debugging is an essential part of development. You can use the built-in debugger in Visual Studio or VS Code to find and fix issues in your code.

                    In Visual Studio, press F5 to start debugging and set breakpoints where needed.
                    In Visual Studio Code, install the C# Debugger extension and press F5 to run the debugger.

                3. Using Git for C# Projects
                    Version control helps manage code changes and collaborate with others efficiently. To initialize a Git repository for your C# project, use the following commands:

                    git init
                    git add .
                    git commit -m "Initial C# project"
                    This initializes a new Git repository, adds all files to staging, and commits them with a message.
             */
        }
    }
}
