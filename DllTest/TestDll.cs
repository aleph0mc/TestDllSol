using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DllTest
{
    // To Register: 1) cd dll folder, 2) C:\Windows\Microsoft.NET\Framework\v4.0.30319\regasm ZipFileComDll.dll /tlb ZipFileComDll.tlb /codebase

    // To Verify registration: 1) cd dll folder, 2) reg query HKLM\SOFTWARE\Classes /s /f ZipFileComDll.dll


    [ComVisible(true)]
    [Guid("1B415838-2C45-4DA0-9ACA-B5D4DF84340D")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ITestDll
    {
        //[DispId(1)]
        int Add2Numbers(int A, int B);
        //[DispId(2)]
        int Sub2Numbers(int A, int B);
    }

    [ComVisible(true)]
    //[Guid("6A909E82-BD75-4F17-8303-71839C029678")]
    [ComDefaultInterface(typeof(ITestDll))]
    [ClassInterface(ClassInterfaceType.None)]
    //[ProgId("ZipFileComDll.ZipFile")]
    public class TestDll : ITestDll
    {
        public int Add2Numbers(int A, int B)
        {
            return A + B;
        }

        public int Sub2Numbers(int A, int B)
        {
            return A - B;
        }
    }
}
