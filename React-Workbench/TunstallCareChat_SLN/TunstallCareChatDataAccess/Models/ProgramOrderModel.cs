using System;
using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
    public class ProgramOrderModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the emitter of the order. Can be an operator or the mobile itself via an administrator user.
        /// </summary>
        /// <value>
        /// The emitter.
        /// </value>
        public String Emitter { get; set; }

        /// <summary>
        /// Gets or sets the ordered date in which It was launched the order.
        /// </summary>
        /// <value>
        /// The ordered date.
        /// </value>
        public DateTime Ordered { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgramOrderModel"/> is ack.
        /// </summary>
        /// <value>
        ///   <c>true</c> if ack; otherwise, <c>false</c>.
        /// </value>
        public Boolean ACK { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgramOrderModel"/> is in or out direction. When "in" orders, the mobile is trying
        /// to program itself with the help of an administrator from the configuration menu in the mobile application. "out" means that an operator tries to 
        /// configurate the mobile from the web site.
        /// </summary>
        /// <value>
        ///   <c>true</c> if direction is coming from the mobile; otherwise, <c>false</c>.
        /// </value>
        public Boolean Direction { get; set; }

public int TerminalId { get; set; }

        /// <summary>
        /// Gets or sets the terminal characteristics that belongs to the program order.
        /// </summary>
        /// <value>
        /// The terminal.
        /// </value>
        public TerminalModel Terminal { get; set; }

        public int OrderCode { get; set; }

        public IEnumerable<ProgrammationModel> Programmations { get; set; }
    }
}