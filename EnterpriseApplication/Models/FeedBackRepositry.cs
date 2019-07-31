using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseApplication.Models
{
    public class FeedBackRepositry : IFeedBackRepositry
    {
        private readonly AppDbContext _appDbContext;

        public FeedBackRepositry(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedBack(FeedBack feedBack)
        {
            _appDbContext.feedBacks.Add(feedBack);
            _appDbContext.SaveChanges();
        }
    }
}
