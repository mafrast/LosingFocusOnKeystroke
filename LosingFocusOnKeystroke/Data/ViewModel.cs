using System;

namespace LosingFocusOnKeystroke.Data
{
    public class ViewModel
    {
        public Guid Id { get; set; }

        public string BusinessKey { get; set; }

        public string Name { get; set; }

        public ViewModel Parent { get; set; }

        public Guid? ParentId => Parent?.Id;
    }
}
