﻿namespace PrincipiosSOLID.ISP
{
    public interface IWriteOnlyRepository<T>
    {
        void Add(T data);
        void Update(T data);
        void Delete(Guid id);
    }
}
