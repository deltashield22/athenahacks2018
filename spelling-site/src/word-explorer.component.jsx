import React from 'react'
import { Button, Glyphicon, Alert } from 'react-bootstrap'
import { VoicePlayer } from 'react-voice-components'
import wordService from './services/word.service'


class WordExplorer extends React.PureComponent {
    constructor(props) {
        super(props);
        this.state = {
            answer: null,
            play: false,
            grade: 2,
            wordIndex: this.props.wordIndex,
            showSuccess: false,
            showFailure: false,
        }
        //number of questions in round passed in as prop
        this.onEnd = this.onEnd.bind(this);
        this.nextQuestion = this.nextQuestion.bind(this);
    }

    componentDidMount() {
        debugger;
        wordService.getListByGrade(this.state.grade)
            .then(words => {
                debugger;
                this.setState({ wordList: words });
                this.setState({ currentWord: words[this.props.wordIndex] })
            })
            .catch(err => console.log(err));
        //serviceCall getUserInfo(score, etc.)
        //serviceCall getWordInfo
    }

    onChange(e) {
        this.setState({ answer: e.target.value });
    }

    onSubmit() {
        let index = this.state.wordIndex++;
        this.setState({ wordIndex: index })
        if (this.state.answer == this.state.currentWord) {
            this.setState({ showSuccess: true })
        }
        else {
            this.setState({ showFailure: true })
        }
    }

    nextQuestion() {
        if(this.state.wordIndex != this.state.words.length) {
            window.location.href = `/word-explorer/${this.props.grade}/${this.state.wordIndex}`;
        }
        else {
            window.location.href = '/main';
        }
        
    }

    onEnd = () => {
        this.setState({ play: false })
    }

    render() {
        let alert = "";
        if (this.state.showFailure) {
            return (
                <Alert bsStyle="danger" onDismiss={this.nextQuestion}>
                    <h4>Incorrect</h4>
                    <p>
                        Oops! That's not quite right. It is spelled "{this.state.currentWord}"
                    </p>
                    <p>
                        <Button onClick={this.nextQuestion}>Next Question</Button>
                    </p>
                </Alert>
            );
        }
        else if(this.state.showSuccess) {
            return (
                <Alert bsStyle="info" onDismiss={this.nextQuestion}>
                    <h4>Correct</h4>
                    <p>
                        Exactly right! How about another one?
                    </p>
                    <p>
                        <Button onClick={this.nextQuestion}>Next Question</Button>
                    </p>
                </Alert>
            );
        }

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
                            <h1>Question {this.state.wordIndex + 1}</h1>
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
                                        text={this.state.currentWord || "Mississippi"}
                                    />
                                )}
                            </div>
                        </div>

                        <div className="row">
                            <div className="col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-sm-6 col-sm-offset-3 col-xs-8 col-xs-offset-2">
                                <div className="form-group">
                                    <input style={{ marginTop: 20 }} type="text" className="form-control input-lg" placeholder="Missip..." onChange={this.onChange.bind(this)} />
                                    <div className="col-md-6 col-md-offset-3">
                                        <Button style={{ marginTop: 20 }} type="button" onClick={this.onSubmit.bind(this)} bsStyle="success" bsSize="large" block>Spell!</Button>
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