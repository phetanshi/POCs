using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformsSamlAuth.Auth
{
    public partial class AssertionConsumerService : System.Web.UI.Page
    {
        public string UserName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string samlCertificate = "MIIC8DCCAdigAwIBAgIQFTZ2FzxEQoFDxg7d4Q9paDANBgkqhkiG9w0BAQsFADA0MTIwMAYDVQQDEylNaWNyb3NvZnQgQXp1cmUgRmVkZXJhdGVkIFNTTyBDZXJ0aWZpY2F0ZTAeFw0yMjA0MTMwODUxNDJaFw0yNTA0MTMwODUxNDJaMDQxMjAwBgNVBAMTKU1pY3Jvc29mdCBBenVyZSBGZWRlcmF0ZWQgU1NPIENlcnRpZmljYXRlMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArTJV/7bKkk5wr12vbBo+epbUC6aWez0kp6fMJu7d4VcWZwJuu+E9Q8LAgjWP2OZITFntQw2CeCiuafwMgvKyIb2ebfsiFbDLcSZR42neeGwcD1E4ur0DYjIUp947DzCAFncMH/M6KXrkt06I38ryFqwDs6pcnQJ11VwXkhXIYS3ZjgeAeFhyeGeOdw5hCnWkPGuoQ7jz5lwzazTtWiWvCbrWNOEkfV/sKFCleoEMW6FY6ECOuObdiYlhDxX4eiUPWSw3ETNizv2tx32QeWh12JyjEBKwJdhhvEdquRrihkmXWOQkA05HeI4ABSUN2NSN5f4HC7mF9ALBQ0+5aZX6dQIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQAmb8EuO5bw9UCnKr4Axtg14yIPcuNDhU4oV5s8HRjFy9+t4QvsIx2BF3BXJ4UEJZinqlBJJxXwFP5E21VvDjpVQw/d4k9eJdmtyAwKolitdnDUyYAp7PnPaLUzSJwnmwSspptYAWLOYHgFmRfjOIfNVmp/f9Q76Z+qsHPJMX2CvHocQ3/m5ToN1757jYoW2Y988tqlxMXM31im97Gl0Z3hSvgnf5WAeuinxuyd/HMVAS/HIns6wBOwQiiCFOwhq8PiJTwYa5xxLj+ohGAcJt2vHWVj9sH+vEkqHn0NjFqj92LWHB45GfY0kPo4FGzjH3mVVmNo3aFZ3/lLmdp4aGwM";
            var samlResponse = new Response(samlCertificate, Request.Form["SAMLResponse"]);

            // 3. We're done!
            if (samlResponse.IsValid())
            {
                //WOOHOO!!! user is logged in
                UserName = samlResponse.GetNameID();
            }
        }
    }
}