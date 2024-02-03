﻿using CodeBE_LEM.Models;

namespace CodeBE_LEM.Repositories
{
    public interface IUOW
    {
        IBoardRepository BoardRepository { get; }
        IJobRepository JobRepository { get; }
    }
    public class UOW : IUOW
    {
        private DataContext DataContext;
        public IBoardRepository BoardRepository { get; private set; }
        public IJobRepository JobRepository { get; private set; }

        public UOW(DataContext DataContext)
        {
            this.DataContext = DataContext;
            this.BoardRepository = new BoardRepository(DataContext);
            this.JobRepository = new JobRepository(DataContext);
        }
    }
}
