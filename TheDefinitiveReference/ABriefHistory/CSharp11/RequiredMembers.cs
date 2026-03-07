using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp11
{
    internal class RequiredMembers
    {
        public static void Run()
        {
            Asset a1 = new Asset { Name = "House" };

            // error: will not compile
            // Asset a2 = new Asset();

  
            AssetSets a3 = new AssetSets("House");
        }

        private class Asset
        {
            // Applying required modifier to a field or property forces consumers of that class or struct to populate that member via an object initializer when constructing it
            public required string Name;
        }


        private class AssetSets
        {
            
            public required string Name;

            // Bypasses the required member restriction for that constructor
            // Promises to initialize required members
            [SetsRequiredMembers]
            public AssetSets(string name)
            {
                Name = name;
            }
        }
    }
}
