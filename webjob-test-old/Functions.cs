using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webjob_test_old
{
    public class Functions
    {
        //Blob Trigger WebJob
        public static async Task BlobTrigger([BlobTrigger("textos/{name}.{txt}")] Stream input, string name)
        {
            //Blob with name {name} and extension {ext}

            using (StreamReader reader = new StreamReader(input))
            {
                //Read the blob content
                string blobContent = await reader.ReadToEndAsync();

            }
        }
    }
}
