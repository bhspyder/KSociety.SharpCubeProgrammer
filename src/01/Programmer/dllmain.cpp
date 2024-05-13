// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

const wchar_t* loaderPath = L"..\\..\\st\\Programmer";

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                       )
{
    UNREFERENCED_PARAMETER(lpReserved);

    WCHAR dllName[MAX_PATH + 1];
    DWORD size = GetModuleFileNameW(hModule, dllName, MAX_PATH);

    if (size > 0)
    {
        std::wstring dllNameStr(dllName);
        std::size_t pos = dllNameStr.size() - 14;
        dllNameStr = dllNameStr.substr(0, pos);
        dllNameStr += loaderPath;
        std::replace(dllNameStr.begin(), dllNameStr.end(), '\\', '/');
        const wchar_t* input = dllNameStr.c_str();

        // Count required buffer size (plus one for null-terminator).
        size_t bufferSize = (wcslen(input) + 1) * sizeof(wchar_t);
        char* buffer = new char[bufferSize];

        size_t convertedSize;
        wcstombs_s(&convertedSize, buffer, bufferSize, input, bufferSize);
        
        switch (ul_reason_for_call)
        {
            case DLL_PROCESS_ATTACH:
                /* Set device loaders path that contains FlashLoader and ExternalLoader folders*/
                SetLoadersPath(buffer);
                break;

            case DLL_THREAD_ATTACH:
                break;

            case DLL_THREAD_DETACH:
                break;

            case DLL_PROCESS_DETACH:
                break;
        }

        delete[] buffer;
        return TRUE;
    }

    return FALSE;
}

