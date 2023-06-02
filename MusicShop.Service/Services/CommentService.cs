<<<<<<< HEAD
﻿
using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShop.Service.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;
        public CommentService(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task<DataBaseResponse<Comment>> Add(Comment comment)
        {
            DataBaseResponse<Comment> response = new DataBaseResponse<Comment>();
            try
            {
                await _commentRepository.Create(comment);
                response.Status = Domain.Enum.StatusCode.OK;
                response.Data = comment;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }
        public async Task<DataBaseResponse<List<Comment>>> GetAll(int productId)
        {
            DataBaseResponse<List<Comment>> response = new DataBaseResponse<List<Comment>>();
            try
            {
                List<Comment> comments = await _commentRepository.GetAll()
                                                    .Where(comment => comment.ProductId == productId)
                                                    .ToListAsync();
                response.Data = comments;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }
    }
}
=======
﻿
using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShop.Service.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;
        public CommentService(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task<DataBaseResponse<Comment>> Add(Comment comment)
        {
            DataBaseResponse<Comment> response = new DataBaseResponse<Comment>();
            try
            {
                await _commentRepository.Create(comment);
                response.Status = Domain.Enum.StatusCode.OK;
                response.Data = comment;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }
        public async Task<DataBaseResponse<List<Comment>>> GetAll(int productId)
        {
            DataBaseResponse<List<Comment>> response = new DataBaseResponse<List<Comment>>();
            try
            {
                List<Comment> comments = await _commentRepository.GetAll()
                                                    .Where(comment => comment.ProductId == productId)
                                                    .ToListAsync();
                response.Data = comments;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
