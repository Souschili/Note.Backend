using MediatR;
using System;

namespace Notes.Application.Notes.Command.CreateNotes
{
    internal class CreateNoteCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Detailes { get; set; }

    }
}
