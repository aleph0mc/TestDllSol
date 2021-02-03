# TestDllSol
Sample COM object DLL  
  
Allows to add as COM DLL as an Automation object to Navision 2009+  
Just as a sample model.  
  
To register (Framework 4):  
regasm "...\Release\DllTest.dll" /tlb "...\Release\DllTest.tlb" /codebase  
  
To unregister  
regasm /u "...\Release\DllTest.dll"
