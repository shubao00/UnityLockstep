﻿using System.Collections.Generic;
using BEPUutilities;
using ECS.Data;                   

namespace ECS
{
    public interface IService
    {

    }
    public interface IDataSource<T> : IService
    {      
        uint Count { get; }

        uint ItemIndex { get; }

        void Insert(T item);

        T GetNext();
    }

    public interface IGridService : IService
    {
        Vector2 GetWorldSize();
        Vector2 GetCellSize();        
    }            

    public interface IFrameDataSource : IDataSource<Frame>
    {                           
    }

    public interface IGameService : IService
    {                                                        
        void LoadEntity(GameEntity entity, int configId);
    }

    public interface INavigationService : IService
    {
        void AddAgent(int id, Vector2 position);

        void SetAgentDestination(int agentId, Vector2 newDestination);

        void Tick();

        Dictionary<int, Vector2> GetAgentPositions();
    }

    public interface IHashService : IService
    {  
        long CalculateHashCode(GameEntity[] hashableEntities);
    }
      
    public interface ILogService : IService
    {
        void Warn(string message);
    }
}