﻿using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace _1.Scripts.DOTS.System.Jobs
{
    public partial struct MovementJob : IJobEntity
    {
        public float Time;
        //public EntityCommandBuffer.ParallelWriter ECBWriter;
        // excute 쿼리에 moving tag 추가 예정
        public void Execute(Entity sampleUnits, ref LocalTransform transform, in SampleUnitComponentData sampleUnitComponentData)
        {
            if (transform.Position.y < 2)
            {
                transform.Position.y = sampleUnitComponentData.movementspeed * Time + transform.Position.y;
            }else{
                // moving tag 취소
            }}
    }
}