using System;
using System.Globalization;
using System.Text.Json;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using SIHSALUS_DocumentGenerator.Utils;

#nullable enable

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;


// Friendly template for developers writing mapping scripts with typing support.
// Contract: Roslyn loader should create an instance and call Create().
public class FUA_Mapping_SETISIS : IDocumentMappingContract
{
    public object Create()
    {
        return ZipHelper.CreatePasswordProtectedEmptyZip("test-password");
    }
}


