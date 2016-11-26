# README

nodejs: 6.9.1, 7.2.0 -- identical behavior

1. try: latest packages -- does not compile


"devDependencies": {
    "fable-compiler": "^0.7.10",
    "node-static": "^0.7.9",
    "source-map-loader": "^0.1.5",
    "webpack": "^1.13.3"
  },
  "dependencies": {
    "fable-core": "^0.7.9",
    "fable-elmish": "^0.5.1",
    "fable-elmish-react": "^0.2.2",
    "fable-import-react": "^0.5.2",
    "react": "^15.4.1",
    "react-dom": "^15.4.1"
  }



2. try: older packages -- compiles

"devDependencies": {
    "fable-compiler": "^0.6.15",
    "node-static": "^0.7.9",
    "source-map-loader": "^0.1.5",
    "webpack": "^1.13.3"
  },
  "dependencies": {
    "fable-core": "^0.6.8",
    "fable-elmish": "^0.4.1",
    "fable-elmish-react": "^0.1.1",
    "fable-import-react": "^0.5.2",
    "react": "^15.4.1",
    "react-dom": "^15.4.1"
  }
