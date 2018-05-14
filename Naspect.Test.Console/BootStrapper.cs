using Naspect.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naspect.Test.Console
{
    public static class BootStrapper
    {
        public static void Configure(IContainer container)
        {
            container.Setup();

            //container.Register<IContainer, SimpleIocContainer>();//CommandDispatcher'ın constructorında ki IContainer için ekliyoruz

            //container.Register<ICommandDispatcher, CommandDispatcher>();
            //container.Register<ICommandHandler<CreateTaskCommand>, CreateTaskCommandHandler>();
            //container.Register<ICommandHandler<ChangeTaskStatusCommand>, ChangeTaskStatusCommandHandler>();

            //container.Register<IQueryDispatcher, QueryDispatcher>();
            //container.Register<IQueryHandler<GetTasksQuery, IQueryable<Task>>, GetTasksQueryHandler>();

            //container.Register<BaseContext, TaskContext>();
            //container.Register<IReadRepository<Task>, BaseRepository<Task>>();
            //container.Register<IWriteRepository<Task>, BaseRepository<Task>>();

        }
    }
}
