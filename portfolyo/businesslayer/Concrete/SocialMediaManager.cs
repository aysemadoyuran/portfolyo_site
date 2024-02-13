using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using businesslayer.Abstract;
using dataaccesslayer.Abstract;
using entitylayer.Concrete;

namespace businesslayer.Concrete
{
    public class SocialMediaManager : ISocialMedia

    {
        ISocialMedia _socialmedia;

        public SocialMediaManager(ISocialMedia socialmedia)
        {
            _socialmedia = socialmedia;
        }

        public void Delete(socialmedia t)
        {
            _socialmedia.Delete(t);
        }

        public socialmedia GetByID(int id)
        {
            return _socialmedia.GetByID(id);
        }

        public List<socialmedia> GetList()
        {
            return _socialmedia.GetList();
        }

        public void Insert(socialmedia t)
        {
            _socialmedia.Insert(t);
        }

        public void Update(socialmedia t)
        {
            _socialmedia.Update(t);
        }
    }
}
