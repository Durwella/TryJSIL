# TryJSIL

This is an exercise in learning to use the [JSIL](http://jsil.org/) "compiler". It generates Javascript from IL (built from C# in this case). 

To run, simply build the solution then open `ConsoleApplication1.html` in a browser.

## Tips

A build of JSIL is included with this example. However, as JSIL is still immature, to work with it you will likely need to build it yourself.  Clone the [JSIL repo](https://github.com/sq/JSIL) with submodules as follows:

    git clone --recursive https://github.com/sq/JSIL.git

If you do not have Microsoft's XNA implementation installed, or if you don't need XNA build solution: `JSIL_NoXNA.sln`

The **Compiler** project builds the `jsilc` command.

You need to create your own HTML host file. Have a look at [ConsoleApplication1.html](ConsoleApplication1.html).  There is more information in the [JSIL Wiki](https://github.com/sq/JSIL/wiki).
