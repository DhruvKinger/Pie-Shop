using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseApplication.Models
{
    public interface IFeedBackRepositry
    {
        void AddFeedBack(FeedBack feedBack);
    }
}
