USE AuctionOnline
GO

INSERT INTO Product_Categories VALUES 
('Art','Art.jpg'),
('Vehicle','Vehicle.jpg'),
('Antique','Antique.jpg'),
('Fashion','Fashion.jpg'),
('Electronics','Electronic.jpg'),
('Other','Other.jpg')
SELECT * FROM Product_Categories
GO

INSERT INTO Sub_category VALUES
--Art category
('Oil Painting',1),
('Wax Painting',1),
('Classic Painting',1),
('Photo',1),
('Statue',1),
('Art Photo',1),
--Vehicle
('Ferrari',2),
('Lamborghini',2),
('Lexus',2),
('Tesla',2),
('Mercedes-Benz',2),
--Antique
('Furniture Antiques',3),
('Ancient Statues',3),
('Ancient Pottery',3),
('Ancient Clock',3),
('Ancient Weapons',3),
('Ancient Books',3),
--Fashion
('Bracelet',4),
('Necklace',4),
('Fashion Shoes',4),
('Ring',4),
('Dress',4),
('Gucci',4),
('Dior',4),
--Electronics
('Phone',5),
('Computer',5),
('Robot',5),
--Other
('Wine',6),
('Villa',6),
('Signature',6),
('Stamp',6),
('Coin',6)
SELECT * FROM Sub_category
GO
DELETE FROM Sub_category
INSERT INTO Products VALUES 
--Oil Painting--
('Mona Lisa','Mona Lisa is one of the most famous oil paintings in the world. A 16th-century portrait painted in oil on a poplar panel in Florence by Leonardo da Vinci during the Italian Renaissance. The work is owned by the French Government and is currently on display at the Louvre in Paris, France as Portrait of Lisa Gherardini, wife of Francesco del Giocondo',15000,1),
('The Starry Night','Painted in June 1889, the painting depicts the scene outside the window of his hospital room in Saint-Rémy-de-Provence, southern France at night, although he painted the picture during the day through his mind. mind. The Starry Night is in the collection of the Museum of Modern Art in New York City, part of the Relics of Lillie P. Bliss, from 1941. The painting is one of van Gogh most famous works. , marking a decisive turning point towards greater creative freedom in his art.',6000 ,1),
('Girl with a Pearl Earring','The oil painting, born around 1665, has been especially noticed by art lovers since becoming the subject of the best-selling historical novel of the same name, published by writer Tracy Chevalier in 1999.Until now, art experts have not been able to decipher the origin of this oil painting, because there is not much information about the artist as well as the model in the picture. The painting is currently on display at the Mauritshuis museum in Den Haag, Netherlands.',35000 ,1),
('The Cafe Terrace on the Place de Forum','This is the first oil painting Van Gogh painted the starry sky as the background. One year after painting Cafe Terrace, Van Gogh continued painting Starry Night. In a letter to his brother Theo, Van Gogh reminded of the Cafe Terrace that he painted "the scene of the cafe on the sidewalk of the Forum Hotel, where we used to go" and "painted at night".', ,1),
('The Birth of Venus','Botticellis oil painting The Birth of Venus is the first full-length, non-religious nude image since antiquity. The painting was painted for Lorenzo de Medici. Venus appeared on the seashore in a giant seashell next to the wind god Zephyrus and Aura as a sign of the arrival of spring in this land.',12000 ,1),
('Les Demoiselles d’Avignon','Les Demoiselles d’Avignon became an iconic oil painting of the 20th century, breaking with tradition commonly found in Western painting, incorporating the African masks Picasso saw at the ethnomuseum. study in Paris. The women depicted in the painting are actually prostitutes in the brothel in Barcelona, the artist’s hometown.',60000,1),
(' The Kiss','The painting The Kiss marks Gustav Klimt’s heyday from 1899-1919 when he often used gold leaf - a technique inspired by a 1903 trip to the Basilica di San Vitale in Ravenna, Italy, where he saw the famous Byzantine mosaics of the church.',70000,1),