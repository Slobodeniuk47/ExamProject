using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CommentImageRepository : GenericRepository<CommentImageEntity>, ICommentImageRepository
    {
        public CommentImageRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IQueryable<CommentImageEntity> CommentImages => GetAll();
        public async Task<List<CommentImageEntity>> GetCommentImagesByCommentIdAsync(int id)
        {
            var commentImages = await CommentImages.Where(x => x.CommentId == id).ToListAsync();
            return commentImages;
        }
        public async Task RemoveCommentImagesByCommentIdAsync(int commentId)
        {
            var imgs = await CommentImages.Where(prodImg => prodImg.CommentId == commentId).ToListAsync();
            _dbContext.CommentImages.RemoveRange(imgs);
        }
    }
}
