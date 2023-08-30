using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Library.Database {
    public class AuthorGetter {
        public List<Author> authors { get; set; }

        public AuthorGetter() {
            authors = new List<Author>() {
                new Author() { Id = 1,    Name = "Miguel De Cervantes",         Description = "Miguel de Cervantes Saavedra was a Spanish writer widely regarded as the greatest writer in the Spanish language and one of the world's pre-eminent novelists. He is best known for his novel Don Quixote, a work often cited as both the first modern novel and one of the pinnacles of world literature." },
                new Author() { Id = 2,    Name = "William Shakespeare",         Description = "William Shakespeare (bapt. 26 April 1564 – 23 April 1616) was an English playwright, poet, and actor, widely regarded as the greatest writer in the English language and the world's greatest dramatist. He is often called England's national poet and the \"Bard of Avon\" (or simply \"the Bard\"). His extant works, including collaborations, consist of some 39 plays, 154 sonnets, three long narrative poems, and a few other verses, some of uncertain authorship. His plays have been translated into every major living language and are performed more often than those of any other playwright. They also continue to be studied and reinterpreted." },
                new Author() { Id = 3,    Name = "Marcel Proust",               Description = "Marcel Proust, (born July 10, 1871, Auteuil, near Paris, France—died November 18, 1922, Paris), French novelist, author of À la recherche du temps perdu (1913–27; In Search of Lost Time), a seven-volume novel based on Proust’s life told psychologically and allegorically." },
                new Author() { Id = 4,    Name = "Herman Melville",             Description = "Herman Melville, (born August 1, 1819, New York City—died September 28, 1891, New York City), American novelist, short-story writer, and poet, best known for his novels of the sea, including his masterpiece, Moby Dick (1851)." },
                new Author() { Id = 5,    Name = "Gabrial Garcia Marquez",      Description = "Gabriel García Márquez was a Colombian novelist, short-story writer, screenwriter, and journalist, known affectionately as Gabo or Gabito throughout Latin America." },
                new Author() { Id = 6,    Name = "Dante Alighieri",             Description = "Dante Alighieri, probably baptized Durante di Alighiero degli Alighieri and often referred to simply as Dante, was an Italian poet, writer and philosopher. His Divine Comedy, originally called Comedìa (modern Italian: Commedia) and later christened Divina by Giovanni Boccaccio, is widely considered one of the most important poems of the Middle Ages and the greatest literary work in the Italian language." },
                new Author() { Id = 7,    Name = "Francis Scott Fitzgerald",    Description = "Francis Scott Key Fitzgerald (September 24, 1896 – December 21, 1940) was an American novelist, essayist, short story and screenwriter. He was best known for his novels depicting the flamboyance and excess of the Jazz Age—a term he popularized. During his lifetime, he published four novels, four collections of short stories, and 164 short stories. Although he achieved temporary popular success and fortune in the 1920s, Fitzgerald received critical acclaim only after his death, and is now widely regarded as one of the greatest American writers of the 20th century." },
                new Author() { Id = 8,    Name = "Homer",                       Description = "Homer was the reputed author of the Iliad and the Odyssey, the two epic poems that are the foundational works of ancient Greek literature. He is regarded as one of the greatest and most influential writers of all time." },
                new Author() { Id = 9,    Name = "James Joyce",                 Description = "James Augustine Aloysius Joyce was an Irish novelist, short story writer, poet, teacher, and literary critic. He contributed to the modernist avant-garde movement and is regarded as one of the most influential and important writers of the 20th century." },
                new Author() { Id = 10,   Name = "Leo Tolstoy",                 Description = "Count Lev Nikolayevich Tolstoy, usually referred to in English as Leo Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time. He received nominations for the Nobel Prize in Literature every year from 1902 to 1906 and for the Nobel Peace Prize in 1901, 1902, and 1909. That he never won is a major controversy." },
            };
        }

        public List<Author> GetAuthors() {
            return authors;
        }

        public Author GetAuthorById(int? _id) {
            int id = _id ?? -1;
            if ((1 <= id) && (id <= authors.Count)) {
                return authors[id - 1];
            }
            return null;
        }
    }
}