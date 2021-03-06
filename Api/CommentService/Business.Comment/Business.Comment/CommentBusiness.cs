using Business.Comment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Business.Comment
{

    /// <summary>
    /// Sample InMemory Business
    /// </summary>
    public class CommentBusiness: ICommentBusiness
    {
        List<CommentDTO> comments;
        public CommentBusiness()
        {
            comments = new List<CommentDTO>();
        }

        /// <summary>
        /// Save Comment
        /// </summary>
        /// <param name="comment"></param>
        public void SaveComment(CommentDTO comment)
        {
            comments.Add(comment);
        }

        /// <summary>
        /// Load Comment List
        /// </summary>
        /// <param name="contextID"></param>
        /// <returns></returns>
        public IEnumerable<CommentDTO> Get(string contextID)
        {
            return comments.Where(d => d.ContextID == contextID);
        }

    }
}
