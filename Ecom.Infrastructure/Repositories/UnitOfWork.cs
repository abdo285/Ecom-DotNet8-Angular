using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; }

        public IPhotoRepository PhotoRepository { get; }

        public IProductRepository ProductRepository { get; }


        private readonly AppDbContext _context;
        public UnitOfWork( AppDbContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(context);
            PhotoRepository = new PhotoRepository(context);
            ProductRepository = new ProductRepository(context);

        }
    }

}
