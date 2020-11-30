using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Data
{
    public class TestClass
    {

        public async Task<string> GetData()
        {
            ServiceReference1.TestClient client = new ServiceReference1.TestClient();

            return await client.GetDataAsync(1);
        }
    }
}
