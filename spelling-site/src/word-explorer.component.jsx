import React from 'react'
import { Button, Glyphicon } from 'react-bootstrap'
import { VoicePlayer } from 'react-voice-components'


class WordExplorer extends React.PureComponent {
    constructor(props) {
        super(props);
        this.state = {
            answer: null,
            play: false,
        }
        //number of questions in round passed in as prop
        this.onEnd = this.onEnd.bind(this);
    }

    componentDidMount() {
        //serviceCall getUserInfo(score, etc.)
        //serviceCall getWordInfo
    }

    onChange(e) {
        this.setState({ answer: e.target.value });
    }

    onClick() {
        //service call to submit answer
        //.then on successful response give success alert
        //.catch on error give error alert
    }

    onEnd = () => {
        this.setState({ play: false })
      }

    render() {
        let buttonStyle = {
            width: '28',
            height: '28',
            cursor: 'pointer',
            pointerEvents: 'none',
            outline: 'none',
            backgroundColor: 'yellow',
            border: 'solid 1px rgba(255,255,255,1)',
            borderRadius: 6
        }

        return (
            <section>
                <div className="container align-items-center">
                    <div className="row">
                        <div style={{ textAlign: 'left', marginBottom: 40 }} className="col-lg-4">
                            <h1>Question 4</h1>
                        </div>
                    </div>

                    <div className="page-component">
                        <div className="row">
                            <div className="col-lg-2 col-lg-offset-5 col-md-2 col-md-offset-5 col-sm-2 col-sm-offset-5 col-xs-4 col-xs-offset-4">
                                <Button type="button" bsStyle="info" bsSize="lg" block onClick={() => this.setState({ play: true })}>
                                    <Glyphicon glyph="volume-up" />
                                </Button>
                                {this.state.play && (
                                    <VoicePlayer
                                        play
                                        text="hello world"
                                    />
                                )}
                            </div>
                        </div>

                        <div className="row">
                            <div className="col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-sm-6 col-sm-offset-3 col-xs-8 col-xs-offset-2">
                                <div className="form-group">
                                    <input style={{ marginTop: 20 }} type="text" className="form-control input-lg" placeholder="Missip..." onChange={this.onChange.bind(this)} />
                                    <div className="col-md-6 col-md-offset-3">
                                        <Button style={{ marginTop: 20 }} type="button" onClick={this.onClick.bind(this)} bsStyle="success" bsSize="large" block>Spell!</Button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        )
    }

}

export default WordExplorer;