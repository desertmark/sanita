using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Sanita.Models
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
    }
}