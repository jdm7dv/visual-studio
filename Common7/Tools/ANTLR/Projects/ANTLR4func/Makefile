#
# Makefile for 4 function calculator using ANTLR
#
# Neil Johnson, 2004, Cambridge University Computer Laboratory
#
# It is assumed that there is a link (or directory) in the current directory
#  containing a copy of the ANTLR runtime DLL.
#

# Change this path to point to where your copy of the antlr.runtime.dll file
#  is located.

ANTLR_PATH = /Users/neiljohnson/Applications/antlr-2.7.2/lib/csharp/ 

Calc.exe: calc.g
	java antlr.Tool $<
	csc /lib:$(ANTLR_PATH) /r:antlr.runtime.dll *.cs

