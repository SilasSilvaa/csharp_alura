Band band = new Band("Band 1");
Genre genre = new Genre("Rock");

Music music = new Music(band, "A", 10, true, genre);
Music music2 = new Music(band, "C", 10, true, genre);

Album album = new Album("AAA");

album.AddMusic(music);
album.AddMusic(music2);

album.ShowAllMusics();

band.AddtoAlbum(album);
band.ShowAlbuns();

Console.WriteLine("--------------");

Episode episode = new Episode("Ep - 1", 1, 20);
Episode episode2 = new Episode("Ep - 2", 2, 20);
Podcast podcast = new Podcast("Main", "PodCast");

podcast.AddEpisode(episode);
podcast.AddEpisode(episode2);

podcast.ShowPodcast();