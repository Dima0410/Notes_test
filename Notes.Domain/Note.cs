using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain
{
    // Здесь будет содержаться описание сущностей заметок, бизнес-логика относящаяся к сущности заметок
    // (Уровень Core => Domain - Interprices logic, относится к общему направлению деятельности компании, очень обобщенная логика)

    class Note
    {
        public Guid UserID { get; set; }
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
    // Notes.Applications: Здесь будет вся логика запросов получения, создания, редактирования заметок и валидации запросов
    // Notes.Persistence: Здесь будет описание взаимодействия с БД
    // Added to GitHub
}
