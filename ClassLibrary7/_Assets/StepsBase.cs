using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7._Assets
{
    public abstract class StepsBase : NBDD.Framework.Testing.NbddStepsBase, IDisposable
    {
        #region Fields

        private FixtureReader innerFixtures;

        #endregion

        #region Properties

        public FixtureReader Fixtures
        {
            get
            {
                this.CreateIfNeededFixtures();
                return this.innerFixtures;
            }
        }

        #endregion

        #region Construction & Destruction

        public void Dispose()
        {
            // todo: descarregar recursos não gerenciados
        }

        #endregion

        #region Auxiliary

        private void CreateIfNeededFixtures()
        {
            if (this.innerFixtures == null)
            {
                this.innerFixtures = new FixtureReader(this);
            }
        }

        #endregion
    }
}
