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
    public class TestimonialManager : ITestimonial
    {
        ITestimonial _testimonial;

        public TestimonialManager(ITestimonial testimonial)
        {
            _testimonial = testimonial;
        }

        public void Delete(testimonial t)
        {
            _testimonial.Delete(t);
        }

        public testimonial GetByID(int id)
        {
            return _testimonial.GetByID(id);
        }

        public List<testimonial> GetList()
        {
            return _testimonial.GetList();
        }

        public void Insert(testimonial t)
        {
            _testimonial.Insert(t);
        }

        public void Update(testimonial t)
        {
            _testimonial.Update(t);
        }
    }
}
