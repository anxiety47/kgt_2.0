import { Component } from '@angular/core';
import { points, pointsBlue } from './points';

@Component({
  selector: 'app-training-map',
  templateUrl: './training-map.component.html',
  styleUrls: ['./training-map.component.scss']
})
export class TrainingMapComponent {

  points = points;
  myLatLng = { lat: 50.01146223876953, lng: 19.82978582382202 };
  mapOptions: google.maps.MapOptions = {
    center: this.myLatLng,
    zoom: 20,
  };

  iconSize = 6;
  icon = {
    url: "/assets/images/dot10px.svg",
    scaledSize: new google.maps.Size(this.iconSize, this.iconSize),
    anchor: new google.maps.Point(this.iconSize/2, this.iconSize/2)
  }

  markerOptions: google.maps.MarkerOptions = {icon: this.icon};

  polylineOptions = {
    path: points,
    strokeColor: '#ff0000',
    strokeOpacity: 1.0,
    strokeWeight: 2,
    };

  polylineOptionsBlue = {
    path: pointsBlue,
    strokeColor: '#0000ff',
    strokeOpacity: 1.0,
    strokeWeight: 4,
  };
}
