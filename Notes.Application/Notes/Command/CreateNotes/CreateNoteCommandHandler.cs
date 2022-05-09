using MediatR;
using Notes.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Command.CreateNotes
{
    internal class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, Guid>
    {
        public Task<Guid> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
            var note = new Note
            {

            };
            return null; // temp
        }
    }
}
