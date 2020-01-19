using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace PFW.CSIST203.Project3.Persisters.Access
{
    public class AccessPersister : IPersistData
    {
        internal readonly string accessFile = null;
        internal bool noDatabase = false;
        internal bool IsDisposed = false;

        public AccessPersister()
        {
            // TODO: Implement
        }

        public AccessPersister(string accessFile)
        {
            // TODO: Implement
            throw new NotImplementedException();
        }

        /// <summary>
        /// The filter used by the open dialog to find files that this persister will handle
        /// </summary>
        /// <returns></returns>
        public string FileFilter
        {
            get
            {
                return "Access Database Files|*.mdb;*.accdb";
            }
        }

        public DataRow GetRow(int id)
        {
            // TODO: Implement
            return null;
        }

        public int CountRows()
        {
            // TODO: Implement
            return 0;
        }

        public void Dispose()
        {
            // TODO: Implement
        }

        public DataTable GetData()
        {
            // TODO: Implement
            return new DataTable();
        }

        public void UpdateRow(DataRow row)
        {
            // TODO: Implement
            throw new NotImplementedException();
        }
    }

}
