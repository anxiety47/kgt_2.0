import { Component, Input, OnInit } from '@angular/core';
import { TrackPoint } from '../../models/trainings';
import { MapInfoWindow, MapMarker } from '@angular/google-maps';

@Component({
  selector: 'app-training-map',
  templateUrl: './training-map.component.html',
  styleUrls: ['./training-map.component.scss']
})
export class TrainingMapComponent implements OnInit {

  @Input() dogTrail: TrackPoint[] = [];
  @Input() personTrail: TrackPoint[] = [];

  dogTrailOptions!: google.maps.PolylineOptions;
  personTrailOptions!: google.maps.PolylineOptions;

  ngOnInit(): void {
    this.dogTrailOptions = {
      path: this.dogTrail,
      strokeColor: '#FF0000',
      strokeOpacity: 1.0,
      strokeWeight: 2,
    };
  
    this.personTrailOptions = {
      path: this.personTrail,
      strokeColor: '#0000FF',
      strokeOpacity: 1.0,
      strokeWeight: 2,
    };
  
  }

  // TODO: wyśrodkować mapę na podstawie obu śladów; w jaki sposób określić zoom?
  myLatLng = { lat: 50.0297879800, lng: 19.8864357546 };
  mapOptions: google.maps.MapOptions = {
    center: this.myLatLng,
    zoom: 18,
  };

  iconSize = 6;
  iconBlue = {
    url: "/assets/images/blue-dot-10.svg",
    scaledSize: new google.maps.Size(this.iconSize, this.iconSize),
    anchor: new google.maps.Point(this.iconSize/2, this.iconSize/2)
  }
  iconRed = {
    url: "/assets/images/red-dot-10.svg",
    scaledSize: new google.maps.Size(this.iconSize, this.iconSize),
    anchor: new google.maps.Point(this.iconSize/2, this.iconSize/2)
  }
  iconRedBig = {
    url: "/assets/images/red-dot-10.svg",
    scaledSize: new google.maps.Size(this.iconSize*2, this.iconSize*2),
    anchor: new google.maps.Point(this.iconSize/2, this.iconSize/2)
  }

  redMarkerOptions: google.maps.MarkerOptions = {icon: this.iconRed};
  blueMarkerOptions: google.maps.MarkerOptions = {icon: this.iconBlue};
  firstRedMarker: google.maps.MarkerOptions = {icon: this.iconRedBig};

  displayInfoWindow(marker: MapMarker, infoWindow: MapInfoWindow): void {
    console.log("open window");
    infoWindow.open(marker);
  }

  markDogStart(index: number): void {
    this.dogTrail.splice(0, index);
    this.dogTrailOptions = {...this.dogTrailOptions};
  }

  markDogEnd(index: number): void {
    this.dogTrail.splice(index + 1);
    this.dogTrailOptions = {...this.dogTrailOptions};
  }

  markPersonStart(index: number): void {
    this.personTrail.splice(0, index);
    this.personTrailOptions = {...this.personTrailOptions};
  }

  markPersonEnd(index: number): void {
    this.personTrail.splice(index + 1);
    this.personTrailOptions = {...this.personTrailOptions};
  }
}
