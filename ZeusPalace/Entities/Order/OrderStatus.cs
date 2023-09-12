﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Order
{
    internal enum OrderStatus
    {
        Open,       // Ο πελάτης προσθέτει αντικείμενα στο καλάθι του
        Placed,     // Ο πελάτης τοποθέτησε την παραγγελία και αναμένει επιβεβαίωση από τον υπάλληλο
        Confirmed,  // Ο υπάλληλος επιβεβαίωσε την παραγγελία και αναμένει εξόφληση από τον πελάτη
        Preparing,  // Ο πελάτης εξόφλησε την παραγγελία (ή προσέθεσε το ποσό στο γενικό του λογαριασμό) και ετοιμάζεται
        Ready,      // Η παραγγελία είναι έτοιμη και αναμένεται παραλαβή από τον πελάτη
        Delivery,   // Η παραγγελία είναι προς παράδοση
        Completed,  // Η παραγγελία παραδόθηκε στον πελάτη
        Canceled    // Ο πελάτης ή ο υπάλληλος ακύρωσε την παραγγελία
    }
}