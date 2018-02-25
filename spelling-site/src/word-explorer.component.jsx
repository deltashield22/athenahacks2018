import React from 'react'
import { Button, Glyphicon } from 'react-bootstrap'

class WordExplorer extends React.PureComponent {
    constructor(props) {
        super(props);
        //number of questions in round passed in as prop
    }

    componentDidMount() {
        //serviceCall getUserInfo(score, etc.)
        //serviceCall getWordInfo
    }

    render() {
        return (
            <section>
                <div className="container align-items-center">
                    <div className="row">
                        <div style={{ textAlign: 'left' }} className="col-lg-4">
                            <h1>Question 4</h1>
                        </div>
                    </div>

                    <div className="page-component">
                        <div className="row">
                            <div className="col-md-2 col-md-offset-5">
                                <Button type="button" bsStyle="info" bsSize="lg" block>
                                    <Glyphicon glyph="volume-up" />
                                </Button>
                            </div>
                        </div>

                        <div className="row">
                            <div className="col-md-6 col-md-offset-3">
                                <div className="form-group">
                                    <input style={{ marginTop: 20 }} type="text" className="form-control input-lg" placeholder="Missip..." />
                                    <div className="col-md-6 col-md-offset-3">
                                        <Button style={{ marginTop: 20 }} type="button" bsStyle="success" bsSize="large" block>Spell!</Button>
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