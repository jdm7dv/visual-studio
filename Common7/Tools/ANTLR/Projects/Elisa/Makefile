#
# Makefile for Elisa simple programming language
#
# Neil Johnson, 2004, Cambridge University Computer Laboratory
#
# It is assumed that there is a link (or directory) in the current directory
#  containing a copy of the ANTLR runtime DLL.
#

# Change this path to point to where your copy of the antlr.runtime.dll file
#  is located.

TARGET = elisacc.exe

ANTLR_PATH = /Users/neiljohnson/Applications/antlr-2.7.2/lib/csharp/ 

SRC =   CodeGen.cs		\
	DotNetCodeGen.cs	\
	Symboltable.cs		\
	ElisaCodeGenerator.cs	\
	ElisaParser.cs     	\
        Elisa.cs

##################################################################

${TARGET}: ${SRC}
	csc /target:exe /lib:$(ANTLR_PATH) /r:antlr.runtime.dll *.cs
	mv Elisa.exe elisacc.exe

ElisaCodeGenerator.cs: ElisaParser.g
	java antlr.Tool ElisaParser.g

ElisaParser.cs: ElisaParser.g
	java antlr.Tool ElisaParser.g


ZIP_FILES = 	Makefile		\
		CodeGen.cs		\
		DotNetCodeGen.cs	\
		Symboltable.cs		\
		ElisaParser.g		\
		Elisa.cs

zip:
	zip Elisa.zip ${ZIP_FILES}

