using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7._Assets
{
    public class FixtureReader
    {
        #region Constants

        private const char StepsClassNameSeparator = '_';
        private const string DefaultFixtureFolder = "_Shared";

        #endregion

        #region Fields

        private StepsBase steps;

        #endregion

        #region Construction & Destruction

        public FixtureReader(
            StepsBase steps)
        {
            this.steps = steps;
        }

        #endregion

        public string Read(string fileName)
        {
            return Path.Combine(
                this.MakeFixtureFoder(),
                fileName);
        }

        #region Auxiliary

        private string MakeFixtureFoder()
        {
            var stepsType = this.steps.GetType();

            var nameFrags = stepsType.Name.Split(new[] { StepsClassNameSeparator }, StringSplitOptions.RemoveEmptyEntries);
            var rootName = nameFrags.FirstOrDefault();

            if (string.IsNullOrWhiteSpace(rootName))
            {
                return DefaultFixtureFolder;
            }

            return rootName;
        }

        #endregion
    }
}
