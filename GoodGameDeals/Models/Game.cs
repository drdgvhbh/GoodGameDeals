﻿namespace GoodGameDeals.Models {
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Windows.UI.Xaml.Media.Imaging;

    public class Game : IEquatable<Game> {
        public Game(
                long id,
                string gameTitle,
                string gameSubtitle,
                BitmapImage image,
                ObservableCollection<Deal> dealsList) {
            this.Id = id;
            this.GameTitle = gameTitle;
            this.GameSubtitle = gameSubtitle;
            this.GameImage = image;
            this.DealsList = dealsList;
        }

        public long Id { get; }

        /// <summary>
        ///     Gets the deals list.
        /// </summary>
        public ObservableCollection<Deal> DealsList { get; }

        /// <summary>
        ///     Gets the game image.
        /// </summary>
        public BitmapImage GameImage { get; }

        /// <summary>
        ///     Gets the game subtitle.
        /// </summary>
        public string GameSubtitle { get; }

        /// <summary>
        ///     Gets the game title.
        /// </summary>
        public string GameTitle { get; }

        public override bool Equals(object obj) {
            return this.Equals(obj as Game);
        }

        public bool Equals(Game other) {
            return other != null &&
                   this.Id == other.Id &&
                   EqualityComparer<ObservableCollection<Deal>>.Default.Equals(this.DealsList, other.DealsList) &&
                   EqualityComparer<BitmapImage>.Default.Equals(this.GameImage, other.GameImage) &&
                   this.GameSubtitle == other.GameSubtitle &&
                   this.GameTitle == other.GameTitle;
        }

        public override int GetHashCode() {
            var hashCode = -1712704214;
            hashCode = hashCode * -1521134295 + this.Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ObservableCollection<Deal>>.Default.GetHashCode(this.DealsList);
            hashCode = hashCode * -1521134295 + EqualityComparer<BitmapImage>.Default.GetHashCode(this.GameImage);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GameSubtitle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GameTitle);
            return hashCode;
        }

        public static bool operator ==(Game game1, Game game2) {
            return EqualityComparer<Game>.Default.Equals(game1, game2);
        }

        public static bool operator !=(Game game1, Game game2) {
            return !(game1 == game2);
        }
    }
}