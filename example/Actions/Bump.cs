﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole.Entities;

namespace SadConsole.Actions
{
    class BumpTile : ActionBase<ActionBasedEntity, Tiles.Tile>
    {
        public BumpTile(ActionBasedEntity source, Tiles.Tile target): base (source, target) { }

        public override void Run(TimeSpan timeElapsed)
        {
            // Assume that this bump is a failure
            Finish(ActionResult.Failure);

            // Tell the tile to process this bump. The tile may set Finish to success or failure.
            Target.ProcessAction(this);
        }
    }

    class BumpGameObject : ActionBase<ActionBasedEntity, ActionBasedEntity>
    {
        public BumpGameObject(ActionBasedEntity source, ActionBasedEntity target): base (source, target) { }

        public override void Run(TimeSpan timeElapsed)
        {
            // Assume that this bump is a failure
            Finish(ActionResult.Failure);

            // Tell the entity to process this bump. The entity may set Finish to success or failure.
            Target.ProcessAction(this);
        }
    }
}