# TestDllSol
Sample COM object DLL  
  
Allows to add this COM DLL as an Automation object even to Navision 2009+  
Just as a sample model.  
  
# IMPORTANT  
Project->Properties->Build tab in Visual Studio, tick  
### "Register for COM Interop"  
  
To register (Framework 4):  
regasm "...\Release\DllTest.dll" /tlb "...\Release\DllTest.tlb" /codebase  
  
To unregister  
regasm /u "...\Release\DllTest.dll"
